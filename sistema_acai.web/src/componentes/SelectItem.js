import React, { Component } from "react";

export default class componentName extends Component {
  render() {
    const { name, img, selected, onSelectItem } = this.props;
    return (
      <div
        className={"item " + (!selected || "selected")}
        onClick={() => onSelectItem(name)}
      >
        <img src={"data:image/png;base64," + img} alt={name}></img>
        <span>{name}</span>
      </div>
    );
  }
}
