import React, {Component, useState} from 'react';
import Menu from '../menu/menu';

const Eight = () => {

  const [data,setData] = useState({
    firstNo : 0,
    secondNo : 0,
    result : ""
  });

  const handleChange = event => {
    setData({
      ...data,[event.target.name] : event.target.value
    })
  }

  const add = () => {
    setData({
      ...data,
      result: parseInt(data.firstNo) + parseInt(data.secondNo)
    });
  }

  const sub = () => {
    setData({
      ...data,
      result: parseInt(data.firstNo) - parseInt(data.secondNo)
    });
  }

  const mult = () => {
    setData({
      ...data,
      result: parseInt(data.firstNo) * parseInt(data.secondNo)
    });
  }

  return(
    <div>
      <Menu/>
      <form>
        <label>First Number : </label>
        <input type= "number" name="firstNo" value={data.firstNo}
          onChange={handleChange} /> <br/><br/>
        <label>Second Number : </label>  
        <input type= "number" name="secondNo" value={data.secondNo}
          onChange={handleChange} /> <br/><br/>
        <input type="button" value="Add" onClick={add}/>  
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type ="button" value="Subtract" onClick={sub} />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input type = "button" value="Multiply" onClick={mult} /><br/><br/>
        <label>Result is : </label>
        <input type="text" value={data.result} readOnly  />
        

      </form>
    </div>
  );
}

export default Eight;