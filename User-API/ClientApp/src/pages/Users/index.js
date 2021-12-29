import React, { useState, useEffect } from 'react';
import './Users.css';

export default function Users() {

    const [users, setUsers] = useState([]);

    function refreshList() {

        const resp =
            fetch('https://localhost:44312/User')
                .then(resp => resp.json())
                .then(data => {
                    console.log(data);
                    setUsers(data);
                })

                .catch(function (error) {
                    console.warn('Somethin went wrong!', error);
                });
    }

    useEffect(() => {
        refreshList();
    }, []);


    return (



        <div className="table-div">
            <table>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>Age</th>
                        <th>Email</th>
                        <th>Username</th>
                        <th>password</th>
                    </tr>
                </thead>

                <tbody>
                    {users.map(u =>
                        <tr>
                            <th>{u.id}</th>
                            <th>{u.firstName}</th>
                            <th>{u.lastName}</th>
                            <th>{u.age}</th>
                            <th>{u.email}</th>
                            <th>{u.username}</th>
                            <th>{u.password}</th>
                        </tr>
                    )}
                </tbody>

            </table>
        </div>

    )
}
