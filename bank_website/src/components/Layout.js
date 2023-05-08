import { Outlet, Link } from "react-router-dom";
import '../styles/Layout.css';
import React, {useState} from 'react';

function Layout() {
  const [open, setOpen] = useState(false);
  return (
    <>
      <nav className= "navBar">
            <Link to="/">Home</Link><br/>
            <div className="dropdown-container">
              <div className="dropdown-trigger" onClick={()=>{setOpen(!open);}}>
                <h1 className="dropdown-profile">Profile</h1>
              </div>
              <div className={`dropdown-menu ${open? 'active' : 'inactive'}`}>
                <ul>
                  <DropdownItem link = {"/blogs"} linkName = {"Blogs"}/>
                  <DropdownItem link = {"/Password"} linkName = {"Password"}/>
                </ul>
              </div>
            </div><br/>
            <Link to="/contact">Contact</Link>
      </nav>
      <Outlet />
    </>
  )
};

function DropdownItem(props) {
  return (
    <li className = "dropdownItem">
      <Link to={props.link}>{props.linkName}</Link>
    </li>
  );
}

export default Layout;