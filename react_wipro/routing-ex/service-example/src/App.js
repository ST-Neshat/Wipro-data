import logo from './logo.svg';
import './App.css';
import UserShow from './components/usershow/usershow';
import EmployShow from './components/employshow/employshow';
import EmploySearch from './components/employsearch/employsearch';
import UserSearch from './components/usersearch/usersearch';

function App() {
  return (
    <div className="App">
      <p>
        <UserShow/>
      </p>
      <p>
        <UserSearch/>
      </p>
      <br/>
      <p>
        <EmployShow/>
      </p>
      <p>
        <EmploySearch/>
      </p>      
    </div>
  );
}

export default App;
