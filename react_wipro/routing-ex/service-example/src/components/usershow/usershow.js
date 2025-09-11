import axios from 'axios';
import React, {Component, useEffect, useState} from 'react';

const UserShow = () => {

    const [employs,setEmployData] = useState([])
    useEffect (() => {
      const fetchData = async () => {
        const response = await
        axios.get("https://jsonplaceholder.typicode.com/users");
        setEmployData(response.data)
      }
      fetchData();
    },[])

  return(
    <div>
      <table border="3" align='center'>
        <tr>
          <th>Id</th>
          <th>Name</th>
          <th>UserName</th>
          <th>Email</th>
          <th>Phone</th>
          <th>Website</th>
        </tr>
    {employs.map((item) => 
      <tr key={item.id}>
        <td>{item.id}</td>
        <td>{item.name}</td>
        <td>{item.username}</td>
        <td>{item.email}</td>
        <td>{item.phone}</td>
        <td>{item.website}</td>
        <td></td>
      </tr>
    )}
      </table>
    </div>
  )
}

export default UserShow;