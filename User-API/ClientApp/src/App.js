import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import Home from './pages/Home';
import Login from './pages/Login';
import Register from './pages/Register';
import NavBar from './components/NavBar';
import Footer from './components/Footer';
import User from './pages/Users';
import NotFound from './pages/NotFound';

function App() {

    return (

        <BrowserRouter>
            <NavBar />
            <Routes>
                <Route exact path='/' element={<Home />} />
                <Route exact path='/login' element={<Login />} />
                <Route exact path='/new' element={<Register />} />
                <Route exact path='/users' element={<User />} />
                <Route path='*' element={<NotFound/>}/>
            </Routes>
            <Footer />
        </BrowserRouter>

    )
}

export default App;
