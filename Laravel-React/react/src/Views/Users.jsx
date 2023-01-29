import {useEffect, useState} from "react";
import axiosClient from "../axios-client.js";
import {Link} from "react-router-dom";
import { useStateContext } from "../Contexts/ContextProvider";

export default function Users() {
  const [users, setUsers] = useState([]);
  const [loading, setLoading] = useState(false);
  const {setNotification} = useStateContext()

  useEffect(() => {
    getUsers();
  }, [])

  const onDeleteClick = user => {
    if (!window.confirm("Biztos törölni akarod a megrendelést?")) {
      return
    }
    axiosClient.delete(`/users/${user.id}`)
      .then(() => {
        setNotification('User was successfully deleted')
        getUsers()
      })
  }

  const getUsers = () => {
    setLoading(true)
    axiosClient.get('/users')
      .then(({ data }) => {
        setLoading(false)
        setUsers(data.data)
      })
      .catch(() => {
        setLoading(false)
      })
  }

  return (
    <div>
      <div style={{display: 'flex', justifyContent: "space-between", alignItems: "center"}}>
        <h1>Users</h1>
        <Link className="btn-add" to="/users/new">Add new</Link>
      </div>
      <div className="card animated fadeInDown">
        <table>
          <thead>
          <tr>
            <th>Honnan</th>
            <th>Hova</th>
            <th>Mit</th>
            <th>MIkor</th>
            <th>Mértékegység</th>
            <th>Actions</th>
          </tr>
          </thead>
          {loading &&
            <tbody>
            <tr>
              <td colSpan="5" class="text-center">
                Loading...
              </td>
            </tr>
            </tbody>
          }
          {!loading &&
            <tbody>
            {users.map(u => (
              <tr key={u.id}>
                <td>{u.id},({u.name})</td>
                <td>{u.name}</td>
                <td>{u.email}</td>
                <td>{u.created_at}</td>
                <td></td>
                <td>
                  <button className="btn-edit" onClick={ev => onDeleteClick(u)}>Megérkezett</button>
                  &nbsp;&nbsp;
                  <button className="btn-delete" onClick={ev => onDeleteClick(u)}>Delete</button>


                </td>
              </tr>
            ))}
            </tbody>
          }
        </table>
      </div>
    </div>
  )
}
