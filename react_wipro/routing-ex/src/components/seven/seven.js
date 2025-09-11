import React, {Component, useState} from 'react';
import Menu from '../menu/menu';

const Seven = () => {

  const[data,setData]=useState(
    {
    firstName : '',
    lastName : '',
    fullName : ''
    }
  )
  
  const handleChange = event => {
    setData({
      ...data,[event.target.name] : event.target.value
    })
  }

  const show = () => {
    setData({
      ...data, fullName : data.firstName + " " + data.lastName
  })
  }

  return(
    <div>
      <Menu/>
      <form>
        <label>First Name: </label>
        <input type="text" name='firstName' value={data.firstName} onChange={handleChange} /> <br/>
        <label>Last Name: </label>
        <input type="text" name='lastName' value={data.lastName} onChange={handleChange}/> <br/>
        <label>Full Name: </label>
        <input type='text' name="fullName" value={data.fullName} readOnly/> <br/>
        <input type="button" value="Show" onClick={show} />
        
      </form>
    </div>
  )

}
export default Seven;