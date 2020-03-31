import React, { Component } from "react";

import Acai from "../img/acai.png";

export default class OrderResume extends Component {
  render() {
    const { flavor, size, additional, total, prepTime } = this.props;

    return (
      <div>
        <img src={Acai} alt="Açaí" />
        <div className="detalhe">
          <span>Tamanho: </span> <span className="value"> {size}</span>
          <br />
          <span>Sabor: </span>
          <span className="value"> {flavor}</span>
          <br />
          <span>Adicionais: </span>
          <span className="value"> {additional && additional.join(", ")}</span>
          <br />
          <br />
          <span>Tempo de Preparo: </span>
          <span className="value"> {prepTime && prepTime + "min"} </span>
          <br />
          <span>Valor:</span>
          <span className="value"> {total && "R$ " + total.toFixed(2)}</span>
          <br />
        </div>

        <button className="button">Fechar Pedido</button>
      </div>
    );
  }
}
