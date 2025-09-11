import React, {Component, useState} from 'react';
import Menu from '../menu/menu';
const Six = () => {
  
  const [sname,setName] = useState("");
  
  const handleChange = event => {
    setName(event.target.value);
    //alert(empno);
  }

  

  return(
    <div>
      <Menu/>
      <form>
        <label>Please Enter Your Name  </label>
        <input type="text" name="sname" value={sname} onChange={handleChange}/>
        
        <br/>
        The Entered name is :<b>{sname}</b>
      </form>
      <hr/>
    </div>
  );
}
export default Six;