import { Outlet, Link } from "react-router-dom";
import '../styles/Layout.css';
import React, {useState} from 'react';

function Layout() {
  const [open, setOpen] = useState(false);

  return (
    <>
      <nav className= "navBar">
            <Link to="/" className = {"link-styles"}>Home</Link>
                <div className="dropdown-profile" onClick={()=>{setOpen(!open);}}>Profile</div>
              <div className={`dropdown-menu ${open? 'active' : 'inactive'}`}>
                <ul>
                  <DropdownItem link = {"/blogs"} linkName = {"Blogs"}/>
                  <DropdownItem link = {"/Password"} linkName = {"Password"}/>
                </ul>
              </div>
            <Link to="/contact" className = {"link-styles"}>Contact</Link>
      </nav>
      <Outlet />
    </>
  )
};

function DropdownItem(props) {
  return (
    <li className = "dropdownItem">
      <Link to={props.link} className = {"link-styles"}>{props.linkName}</Link>
    </li>
  );
}

export default Layout;