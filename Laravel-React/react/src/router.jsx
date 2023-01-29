import { createBrowserRouter, Navigate } from "react-router-dom"
import Login from "./Views/Login";
import SignUp from "./Views/SignUp";
import Users from "./Views/Users";
import Defaultlayout from "./components/Defaultlayout";
import Guestlayout from "./components/Guestlayout";
import Dashboard from "./Views/Dashboard";
import { Children } from "react";
import NotFound from "./Views/NotFound";
import UserForm from "./Views/UserForm";

const router = createBrowserRouter([
  {
    path: '/',

    element: <Defaultlayout/>,
    children: [
      {
        path: '/',
        element: <Navigate to="/users"/>
      },
      {
        path: '/dashboard',
        element: <Dashboard/>
      },
      {
        path: '/users',
        element: <Users/>
      },
      {
        path: '/users/new',
        element: <UserForm key={"userCreate"}/>
      },
      {
        path: '/users/:id',
        element: <UserForm key={"userUpdate"}/>
      }
    ]
  },
  {
    path: '/',
    element: <Guestlayout/>,
    children: [
      {
        path: '/login',
        element: <Login/>
      },
      {
        path: '/signup',
        element: <SignUp/>
      }
    ]
  },
  {
    path: "*",
    element: <NotFound/>
  }
])

export default router;
