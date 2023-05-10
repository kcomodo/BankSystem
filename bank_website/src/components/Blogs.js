import '../styles/Blogs.css';
import * as React from 'react';  
import {Link} from 'react-router-dom';

function Blogs() {
  const [open, setOpen] = React.useState(false);
  const [open1, setOpen1] = React.useState(false);

  const handleBox = () => {
    setOpen(!open);
  };

  const handleProfile = () => {
    setOpen1(!open1);
  }
    return (
      <div className='center'>
        <nav className={`box1 ${open? 'active' : 'inactive'}`}>
          <Link to="/" className = {"link-styles"}>Home</Link>
                  <div className="dropdown-profile" onClick={handleProfile}>Profile
                  <img src = {require('../images/dropdown.jpg')} alt = "dropDownIcon" className = "dropDownIcon"></img>
                  </div>
                <div className={`dropdown-menu ${open1? 'active' : 'inactive'}`}>
                  <ul>
                  <DropdownItem link = {"/Personal Info"} linkName = {"Personal Info"}/>
                    <DropdownItem link = {"/Username"} linkName = {"Username"}/>
                    <DropdownItem link = {"/Password"} linkName = {"Password"}/>
                    <DropdownItem link = {"/E-Mail"} linkName = {"E-Mail"}/>
                    <DropdownItem link = {"/Phone Number"} linkName = {"Phone Number"}/>
                  </ul>
                </div>
              <Link to="/logOut" className = {"link-styles"}>Log Out</Link>
        </nav>
        <img src = {require('../images/menu.png')} alt = "menuIcon" onClick={handleBox} className = "box2"></img>
      </div>
    );

    function DropdownItem(props) {
      return (
        <div className = "dropdownItem">
          <Link to={props.link} className = {"link-styles"}>{props.linkName}</Link>
        </div>
      );
    }
  };
  
  export default Blogs;