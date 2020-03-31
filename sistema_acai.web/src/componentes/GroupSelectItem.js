import React, { Component } from "react";

import SelectItem from "./SelectItem";

export default class GroupSelectItem extends Component {
  render() {
    const { title, list, onSelectItem } = this.props;

    return (
      <div className="group-select">
        <span className="title">{title}</span>
        <div className="group-item">
          {list.map((item, index) => (
            <SelectItem
              key={index}
              name={item.name}
              img={item.img}
              selected={item.selected}
              onSelectItem={onSelectItem}
            />
          ))}
        </div>
      </div>
    );
  }
}
