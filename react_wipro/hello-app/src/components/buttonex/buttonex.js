import React, {Component} from 'react';
//import './buttonex.scss'

const Buttonex = () => {

  const neshat = () =>{
    alert("Hi I am Neshat...");
  }

  const rajesh = () =>{
    alert("Hi I am Rajesh...");
  }

  const venkata = () =>{
    alert("Hi I am Venkata...");
  }

  return(
    <div>
      <input type= "button" value="Neshat" onClick={neshat} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Rajesh" onClick={rajesh} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <input type="button" value="Venkata" onClick={venkata} />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </div>
  );
}
export default Buttonex;