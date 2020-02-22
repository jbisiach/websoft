"use strict";

import  generate_lotto from "./lottoGen.js"
(function(){
    let selectable_container = document.getElementById("container-selectable");
    let results_container = document.getElementById("container-result");
    let results_button = document.getElementById("results-button");

    function createResultNode(number) {
        let node = document.createElement('div');
        node.classList.add('result');
        node.innerHTML = number;
        return node;
    }

    results_button.addEventListener("click", () => {
        results_container.innerHTML = "";
        generate_lotto(7,1,35).forEach(number => {
            results_container.appendChild(createResultNode(number));
        });
    });
}());