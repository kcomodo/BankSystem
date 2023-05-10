import '../styles/Contact.css';
import * as React from 'react';  
import {Link} from 'react-router-dom';
function Contact() {
  const [open, setOpen] = React.useState(false);

  const handleNav = () => {
    setOpen(!open);
  };

  const handleProfile = () => {
    setOpen(false);
  }

    return (
      <div className='testing'>
        <nav className={`navBar ${open? 'active' : 'inactive'}`}>
          <Link to="/" className = {"link-styles"}>Home</Link>
                  <div className="dropdown-profile" onClick={handleProfile}>Profile</div>
                <div className={`dropdown-menu ${open? 'active' : 'inactive'}`}>
                  <ul>
                    <DropdownItem link = {"/blogs"} linkName = {"Blogs"}/>
                    <DropdownItem link = {"/Password"} linkName = {"Password"}/>
                  </ul>
                </div>
              <Link to="/contact" className = {"link-styles"}>Contact</Link>
        </nav>
        <img src = {require('../images/menu.png')} alt = "menuIcon" onClick={handleNav} className = "menuIcon"></img>
      </div>
      
    );

    function DropdownItem(props) {
      return (
        <li className = "dropdownItem">
          <Link to={props.link} className = {"link-styles"}>{props.linkName}</Link>
        </li>
      );
    }
  };

  
export default Contact;