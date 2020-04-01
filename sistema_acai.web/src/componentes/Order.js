import React, { Component } from "react";

import GroupSelectItem from "./GroupSelectItem";
import OrderResume from "./OrderResume";
import { API_PATH } from "./api";

import "./order.css";

export default class Order extends Component {
  state = {
    flavors: [],
    sizes: [],
    additionals: [],
    order: {}
  };

  selectSize = name => {
    const newsizes = this.state.sizes.map(f => ({
      ...f,
      selected: f.name === name ? true : false
    }));

    this.setState({
      sizes: newsizes
    });

    const flavors = this.state.flavors.filter(f => f.selected).map(f => f.name);
    const sizes = newsizes.filter(f => f.selected).map(f => f.name);
    const additionals = this.state.additionals
      .filter(f => f.selected)
      .map(f => f.name);
    this.CalculaOrder(flavors, sizes, additionals);
  };

  selectFlavor = name => {
    const newflavors = this.state.flavors.map(f => ({
      ...f,
      selected: f.name === name ? true : false
    }));

    this.setState({
      flavors: newflavors
    });

    const flavors = newflavors.filter(f => f.selected).map(f => f.name);
    const sizes = this.state.sizes.filter(f => f.selected).map(f => f.name);
    const additionals = this.state.additionals
      .filter(f => f.selected)
      .map(f => f.name);
    this.CalculaOrder(flavors, sizes, additionals);
  };

  selectAditional = name => {
    const newAdditionals = this.state.additionals.map(f => ({
      ...f,
      selected: f.name === name ? !f.selected : f.selected
    }));

    this.setState({
      additionals: newAdditionals
    });

    const flavors = this.state.flavors.filter(f => f.selected).map(f => f.name);
    const sizes = this.state.sizes.filter(f => f.selected).map(f => f.name);
    const additionals = newAdditionals.filter(f => f.selected).map(f => f.name);
    this.CalculaOrder(flavors, sizes, additionals);
  };

  CalculaOrder = (flavors, sizes, additionals) => {
    fetch(API_PATH + "/order/calcula_order", {
      method: "POST",
      headers: {
        accept: "text/plan",
        "Content-Type": "application/json"
      },
      body: JSON.stringify({
        flavor: flavors.length > 0 ? flavors[0] : "",
        acaiSize: sizes.length > 0 ? sizes[0] : "",
        additional: additionals
      })
    })
      .then(result => result.json())
      .then(result => {
        this.setState({
          order: {
            total: result.total,
            prepTime: result.prepTime
          }
        });
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
    const {
      flavors,
      sizes,
      additionals,
      order: { total, prepTime }
    } = this.state;

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
            total={total}
            prepTime={prepTime}
          />
        </div>
      </div>
    );
  }
}
