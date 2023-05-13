import {Link} from "react-router-dom";
import '../styles/NavBar.css';
import React from 'react';

function NavBar() {
  const [open, setOpen] = React.useState(false);
  const [open1, setOpen1] = React.useState(false);

  const handleBox = () => {
    setOpen(!open);
  };

  const handleProfile = () => {
    setOpen1(!open1);
  }
    return (
      <div className='navBar'>
        <nav className={`box1 ${open? 'active' : 'inactive'}`}>
            <LinkItem link = {"/"} linkName = {"Home"} imgSource = {require('../images/home.png')} altName = {'homeIcon'}/>
                  <div className="dropdown-profile" onClick={(handleProfile)}>Profile
                  <img src = {require('../images/dropdown.png')} alt = "dropDownIcon" className = {`dropDownIcon ${open1? 'active' : 'inactive'}`}></img>
                  </div>
                <div className={`dropdown-menu ${open1? 'active' : 'inactive'}`}>
                    <DropdownItem link = {"/PersonalInfo"} linkName = {"Personal Info"} imgSource = {require('../images/profile.png')} altName = {'profileIcon'}/>
                    <DropdownItem link = {"/Username"} linkName = {"Username"} imgSource = {require('../images/username.png')} altName = {'usernameIcon'}/>
                    <DropdownItem link = {"/Password"} linkName = {"Password"} imgSource = {require('../images/password.png')} altName = {'passwordIcon'}/>
                    <DropdownItem link = {"/Email"} linkName = {"E-Mail"} imgSource = {require('../images/email.png')} altName = {'emailIcon'}/>
                    <DropdownItem link = {"/Phone Number"} linkName = {"Phone Number"} imgSource = {require('../images/phone.png')} altName = {'phoneIcon'}/>
                </div>
                <LinkItem link = {"/LogOut"} linkName = {"Log Out"} imgSource = {require('../images/logout.png')} altName = {'logoutIcon'}/>
        </nav>
        <img src = {require('../images/menu.png')} alt = "menuIcon" onClick={handleBox} className = "box2"></img>
      </div>
    );

    function DropdownItem(props) {
      return (
        <div className = "dropdownItem">
          <Link to={props.link} className = {"link-styles"}>{props.linkName}
          <img src = {props.imgSource} alt = {props.altName} className = {props.altName}></img>
          </Link>
        </div>
      );
    }

    function LinkItem(props) {
      return (
        <div className = "LinkItem">
          <Link to={props.link} className = {"link-styles"}>{props.linkName}
          <img src = {props.imgSource} alt = {props.altName} className = {props.altName}></img>
          </Link>
        </div>
      );
    }
  }
export default NavBar;