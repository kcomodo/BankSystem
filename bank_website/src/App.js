import React from 'react';
import './styles/App.css';
import './styles/index.css';
import Layout from './components/Layout';
import Home from './components/Home';
import Blogs from './components/Blogs';
import NoPage from './components/NoPage';
import Contact from './components/Contact';
import Password from './components/Password';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
    <Routes>
        <Route exact path="/" element={<Layout/>}>
          <Route path="Home" element={<Home/>}/>
          <Route path="blogs" element={<Blogs/>}/>
          <Route path="Password" element={<Password/>}/>
          <Route path="contact" element={<Contact/>}/>
          <Route path="*" element={<NoPage/>}/>
        </Route>
    </Routes>
  </BrowserRouter>
  );
}

export default App;
