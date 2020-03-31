import React from "react";
import "./App.css";

import Order from "./componentes/Order";
import Header from "./componentes/Header";

function App() {
  return (
    <div className="container">
      <Header />
      <Order />
    </div>
  );
}

export default App;
