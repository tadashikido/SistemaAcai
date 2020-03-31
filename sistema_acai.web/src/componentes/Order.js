import React, { Component } from "react";

import GroupSelectItem from "./GroupSelectItem";
import OrderResume from "./OrderResume";
import { API_PATH } from "./api";

import "./order.css";

import Morango from "../img/morango.png";
import Kiwi from "../img/kiwi.png";
import Banana from "../img/banana.png";
import Pequeno from "../img/pequeno.png";
import Medio from "../img/medio.png";
import Grande from "../img/grande.png";
import Granola from "../img/granola.png";
import LeiteNinho from "../img/ninho.png";
import Pacoca from "../img/pacoca.png";

export default class Order extends Component {
  state = {
    flavors: [],
    sizes: [],
    additionals: [],
    order: {}
  };

  selectSize = name => {
    this.setState({
      sizes: this.state.sizes.map(f => ({
        ...f,
        selected: f.name === name ? true : false
      }))
    });
  };

  selectFlavor = name => {
    this.setState({
      flavors: this.state.flavors.map(f => ({
        ...f,
        selected: f.name === name ? true : false
      }))
    });
  };

  selectAditional = name => {
    this.setState({
      additionals: this.state.additionals.map(f => ({
        ...f,
        selected: f.name === name ? !f.selected : f.selected
      }))
    });
  };

  componentDidMount() {
    fetch(API_PATH + "/product/sizes", { method: "GET" })
      .then(result => result.json())
      .then(result => {
        this.setState({
          sizes: result.map(r => ({
            name: r.name,
            img: r.img,
            selected: false
          }))
        });
      });

    fetch(API_PATH + "/product/flavors", { method: "GET" })
      .then(result => result.json())
      .then(result => {
        this.setState({
          flavors: result.map(r => ({
            name: r.name,
            img: r.img,
            selected: false
          }))
        });
      });

    fetch(API_PATH + "/product/additionals", { method: "GET" })
      .then(result => result.json())
      .then(result => {
        this.setState({
          additionals: result.map(r => ({
            name: r.name,
            img: r.img,
            selected: false
          }))
        });
      });
  }

  render() {
    const { flavors, sizes, additionals } = this.state;

    return (
      <div className="order">
        <div className="items">
          <GroupSelectItem
            title="Selecione o tamanho"
            list={sizes}
            onSelectItem={name => this.selectSize(name)}
          />
          <GroupSelectItem
            title="Selecione o sabor"
            list={flavors}
            onSelectItem={name => this.selectFlavor(name)}
          />
          <GroupSelectItem
            title="Selecione os adicionais"
            list={additionals}
            onSelectItem={name => this.selectAditional(name)}
          />
        </div>
        <div className="resume">
          <OrderResume
            size={sizes.filter(f => f.selected).map(f => f.name)}
            flavor={flavors.filter(f => f.selected).map(f => f.name)}
            additional={additionals.filter(f => f.selected).map(f => f.name)}
            total={10}
            prepTime={2}
          />
        </div>
      </div>
    );
  }
}
