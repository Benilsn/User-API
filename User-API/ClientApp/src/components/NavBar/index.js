import React from 'react';
import './NavBar.css';

export default function NavBar(){
    return (
        <header>
        <nav className="menu">
            <ul>
                <li><a href="/">Home</a></li>
                <li><a href="">List Model</a>
                    <ul>
                        <li><a href="/users">All Users </a></li>
                        <li><a href="">Item 2</a></li>
                        <li><a href="">Item 3</a></li>
                        <li><a href="">Item 4 </a></li>
                        <li><a href="">Item 5</a></li>
                        <li><a href="">Item 6</a></li>
                    </ul>
                </li>
            </ul>
            <li><a href="/login">Sign in</a></li>
            <li><a href="/new">Sign up</a></li>
        </nav>
    </header>
    
    )

}
