(function(){

    var duck = document.getElementById("duck")
    var offsetWidth = duck.offsetWidth
    var offsetHeight = duck.offsetHeight
    var w = window.innerWidth;
    var h = window.innerHeight;
    var hidden = false;

    setInterval(function(){
        
        duck.style.visibility = hidden ? 'visible' : 'hidden'
        hidden = !hidden

        var newX = Math.floor(Math.random() * (w))
        var newY = Math.floor(Math.random() * (h))


        if(newX >= (w-offsetWidth)){
            duck.style.left = newX-duck.offsetWidth + "px"
        } else {
            duck.style.left = newX + "px"
        }
       
        if(newY >= (h-offsetHeight)){
            duck.style.top  = newY-duck.offsetHeight+ "px"
        }else{
            duck.style.top  = newY+ "px"
        }
    },750)

    duck.addEventListener("click", function(){
        
    
    })

    window.addEventListener("resize", function(){
         w = window.innerWidth;
         h = window.innerHeight;
    })

    console.log(duck.style.width)
    console.log(duck)
    console.log("Duck ready")
})();