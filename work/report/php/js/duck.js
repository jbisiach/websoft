"use strict"

function moveElmRand(elm){ 
    elm.style.position ='absolute'; 
    elm.style.top = Math.floor(Math.random()*90+5)+'%'; 
    elm.style.left = Math.floor(Math.random()*90+5)+'%'; 
   } 
    
   var duck = document.querySelector('#duck'); 
    
   duck.addEventListener('mouseover', function(e){ moveElmRand(e.target);}); 
    
   btn_test.addEventListener('click', function(e){ alert('Fast hands!');});