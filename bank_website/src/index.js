import React from 'react';
import ReactDOM from 'react-dom/client';
import './styles/index.css';
import Layout from './components/Layout';
import Home from './components/Home';
import Blogs from './components/Blogs';
import NoPage from './components/NoPage';
import Contact from './components/Contact';
import Password from './components/Password';
import {BrowserRouter, Routes, Route} from 'react-router-dom';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<Layout/>}>
        <Route index element={<Home/>}/>
        <Route path="blogs" element={<Blogs/>}/>
        <Route path="Password" element={<Password/>}/>
        <Route path="contact" element={<Contact/>}/>
        <Route path="*" element={<NoPage/>}/>
      </Route>
    </Routes>
  </BrowserRouter>

);

