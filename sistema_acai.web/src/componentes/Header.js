import React, { Component } from "react";

import "./header.css";

export default class Header extends Component {
  render() {
    return (
      <div className="header">
        <span className="title">Sistema de Pedido de Açaí</span>
        <span className="subtitle">Monte o seu Açaí e peça já</span>
      </div>
    );
  }
}
