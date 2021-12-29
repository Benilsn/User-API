import React, { useState } from 'react';
import NavBar from '../../components/NavBar';
import Footer from '../../components/Footer';
import './Login.css';

export default function User() {


    const [username, setUserName] = useState('');
    const [password, setPassword] = useState('');


    function login(e) {

        if (username !== '' && password !== '') {
            alert(`Username: ${username}\nPassword:${password}`)
        } else {
            this.setState({ error: "Eroooou!" })
        }

        e.preventDefault();
    }

    return (
        <>
            <NavBar />

            <div class="login-div">
                <form onSubmit={login}>
                    <h1 class="login-div">Sign in</h1>
                    <p class="login-div">Username :</p>

                    <input type="text"
                        class="login-div"
                        name="username"
                        value={username}
                        onChange={e => setUserName(e.target.value)} placeholder="Username" />
                    <br />
                    <p class="login-div" >Password :</p>

                    <input
                        type="password"
                        class="login-div" name="password"
                        value={password}
                        onChange={e => setPassword(e.target.value)} placeholder="Password" />
                    <button class="login-div" type="submit">Confirm</button>
                </form>
            </div>

            <Footer />
        </>
    )

}
