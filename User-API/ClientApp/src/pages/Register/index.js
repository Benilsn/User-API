import React, { Component } from 'react';
import NavBar from '../../components/NavBar';
import Footer from '../../components/Footer';
import './Register.css';

export default class Register extends Component {

    constructor(props) {
        super(props);
        collapse = { showing: true };
        this.state = {
            firstname: '',
            lastname: '',
            age: '',
            email: '',
            username: '',
            password: '',
            confirmPassword: ''
        }

        this.handleFirtname = this.handleFirtname.bind(this);
        this.handleLastName = this.handleLastName.bind(this);
        this.handleAge = this.handleAge.bind(this);
        this.handleEmail = this.handleEmail.bind(this);
        this.handleUsername = this.handleUsername.bind(this);
        this.handlePassword = this.handlePassword.bind(this);
        this.handleConfirmPassword = this.handleConfirmPassword.bind(this);

        this.handleSubmit = this.handleSubmit.bind(this);
    }

    handleFirtname(event) {
        this.setState({ firstname: event.target.value });
    }

    handleLastName(event) {
        this.setState({ lastname: event.target.value });
    }

    handleAge(event) {
        this.setState({ age: event.target.value });
    }

    handleEmail(event) {
        this.setState({ email: event.target.value });
    }

    handleUsername(event) {
        this.setState({ username: event.target.value });
    }

    handlePassword(event) {
        this.setState({ password: event.target.value });
    }

    handleConfirmPassword(event) {
        this.setState({ confirmPassword: event.target.value });
    }

    handleSubmit(event) {
        alert('Um nome foi enviado: ' + this.state.value);
        event.preventDefault();
    }



    render() {
        const { showing } = this.collapse;
        return (
            <>
                <NavBar />

                <form method='POST' action='https://localhost:44312/register' id="register-form" >

                    <br />

                    <div class="register-div" id='el1' >
                        <h2 class="register-div">Personal info</h2>
                        <br />
                        <label class="register-div">First Name :</label>

                        <input
                            type="text"
                            class="register-div"
                            name="firstName"
                            value={this.state.firstname}
                            onChange={this.handleFirtname}
                            placeholder='First Name'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>

                        <label class="register-div" >Last Name :</label>

                        <input
                            type="text"
                            class="register-div"
                            name="lastName"
                            value={this.state.lastname}
                            onChange={this.handleLastName}
                            placeholder='Last Name'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>


                        <label class="register-div">Age :</label>

                        <input
                            type="text"
                            class="register-div"
                            name="age"
                            value={this.state.age}
                            onChange={this.handleAge}
                            placeholder='Age'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>

                        <label class="register-div">E-mail :</label>

                        <input
                            type="email"
                            class="register-div"
                            name="email"
                            value={this.state.email}
                            onChange={this.handleEmail}                        
                            placeholder='E-mail'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>
                        <button class="next-btn" type="button" >Next</button>

                    </div>
                    <div class="account" id="el2">
                        <h2 class="account">Account settings</h2>
                        <br />

                        <label class="register-div">Username :</label>
                        <input
                            type="text"
                            class="register-div"
                            name="username"
                            value={this.state.username}
                            onChange={this.handleUsername}
                            placeholder='Username'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>


                        <label class="register-div">Password :</label>
                        <input
                            type="password"
                            class="register-div"
                            name="password"
                            value={this.state.password}
                            onChange={this.handlePassword}
                            placeholder='Password'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>


                        <label class="cregister-div">Comfirm Password :</label>

                        <input
                            type="password"
                            class="register-div"
                            name="confirm-password"
                            value={this.state.confirmPassword}
                            onChange={this.handleConfirmPassword}
                            placeholder='Confirm Password'></input>
                        <br />
                        <br />
                        <h6 class="warn-msg">null</h6>

                        <button class="register-div" type="submit">Submit</button>
                    </div>


                </form>




                <Footer />

            </>
        )}
}
