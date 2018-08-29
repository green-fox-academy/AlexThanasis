var angle = PI/4;

function setup(){
    createCanvas(400, 400);
}

function draw(){
    background(51);
    angle = slider.value();
    stroke(255);
    translate(200, height);
    branch(100);
}

function branch(len){
    line(0, 0, 0, -len);
    translate(0, -len);
    if(len > 4){
        push();
        rotate(angle);
        branch(len * 0.67);
        pop();
        push();
        rotate(-angle);
        branch(len * 0.67);
        pop();

    }
    
}