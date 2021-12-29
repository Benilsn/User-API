import React, { useEffect, useState } from 'react';
import NavBar from '../../components/NavBar';
import Footer from '../../components/Footer';
import './Register.css';

export default function Register() {

    const [firstname, setFirstName] = useState('');
    const [lastname, setLastName] = useState('');
    const [age, setAge] = useState('');
    const [email, setEmail] = useState('');
    const [username, setUserName] = useState('');
    const [password, setPassword] = useState('');

    return (
        <>
            <NavBar />

            <div class="register-div">
                <form method='POST' action='https://localhost:44312/register'>
                    <h1 class="register-div">Register</h1>
                    <label class="register-div">First Name :</label>

                    <input
                        type="text"
                        class="register-div"
                        name="firstName"
                        value={firstname}
                        onChange={e => setFirstName(e.target.value)}
                        placeholder='First Name'></input>
                    <br />
                    <br />

                    <label class="register-div" >Last Name :</label>

                    <input
                        ype="text"
                        class="register-div"
                        name="lastName"
                        value={lastname}
                        onChange={e => setLastName(e.target.value)}
                        placeholder='Last Name'></input>
                    <br />
                    <br />

                    <label class="register-div">Age :</label>

                    <input
                        type="text"
                        class="register-div"
                        name="age"
                        value={age}
                        onChange={e => setAge(e.target.value)}
                        placeholder='Age'></input>
                    <br />
                    <br />
                    <label class="register-div">E-mail :</label>

                    <input
                        type="email"
                        class="register-div"
                        name="email"
                        value={email}
                        onChange={e => setEmail(e.target.value)}
                        placeholder='E-mail'></input>
                    <br />
                    <br />

                    <label class="register-div">Username :</label>

                    <input
                        type="text"
                        class="register-div"
                        name="username"
                        value={username}
                        onChange={e => setUserName(e.target.value)}
                        placeholder='Username'></input>
                    <br />
                    <br />

                    <label class="register-div">Password :</label>

                    <input
                        type="password"
                        class="register-div"
                        name="password"
                        value={password}
                        onChange={e => setPassword(e.target.value)}
                        placeholder='Password'></input>


                    <button class="register-div" type="submit">Submit</button>
                </form>
            </div>

            <Footer />

        </>
    )

}
