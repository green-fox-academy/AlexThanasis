var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");

var dy = -1;
var bulletRadius = 3;

var paddleHeight = 20;
var paddleWidth = 10;
var paddleX = (canvas.width - paddleWidth) / 2; 
var rightPressed = false;
var leftPressed = false;
var spacePressed = false;

var enemySpeed = 2;
var bulletX = paddleX;
var bulletY = canvas.height - 30;
var bulletIsFired = false;
var bulletIsReady = true;
var brickRowCount = 3;
var brickColumnCount = 5;
var brickWidth = 75;
var brickHeight = 20;
var brickPadding = 10;
var brickOffsetTop = 30;
var brickOffsetLeft = 30;
var difficultyLevel = 1;

var score = 0;
var lives = 1;

var bricks = [];
for(var c=0; c<brickColumnCount; c++) {
    bricks[c] = [];
    for(var r=0; r<brickRowCount; r++) {
        bricks[c][r] = { x: 0, y: 0, brickLives : difficultyLevel};
    }
}

document.addEventListener("keydown", keyDownHandler, false);
document.addEventListener("keyup", keyUpHandler, false);
document.addEventListener("mousemove", mouseMoveHandler, false);

function keyDownHandler(e){
    if(e.keyCode == 39){
        rightPressed = true;
    }
    else if(e.keyCode == 37){
        leftPressed = true;
    }
    else if(e.keyCode == 38){
        spacePressed = true;
    }
}

function keyUpHandler(e){
    if(e.keyCode == 39){
        rightPressed = false;
    }
    else if(e.keyCode == 37){
        leftPressed = false;
    }
    else if(e.keyCode == 38){
        spacePressed = false;
    }
}

function mouseMoveHandler(e){
    var relativeX = e.clientX - canvas.offsetLeft;
    if(relativeX > 0 && relativeX < canvas.width){
        paddleX - relativeX - paddleWidth/2;
    }
}

function collisionDetector(){
    for(var c=0; c<brickColumnCount; c++) {
        for(var r=0; r<brickRowCount; r++) {
            var b = bricks[c][r];
            b.y += enemySpeed;
            if(bulletX > b.x && bulletX < b.x + brickWidth
                && bulletY > b.y && bulletY < b.y + brickHeight && b.brickLives > 0){
                    b.brickLives--;
                    if(b.y > canvas.height - 15){
                        alert("Game Over! Your score: " + score);
                        document.location.reload();
                    }
                    score++;
                    if(score == brickColumnCount * brickRowCount * difficultyLevel){
                        alert("You WIN! Congratulation!");
                        document.location.reload();
                    }
                }
        }
    }
}

function drawScore(){
    ctx.font = "16px Arial";
    ctx.fillStyle = "#0095DD";
    ctx.fillText("Score: " + score, 8, 20);
}

function drawLives() {
    ctx.font = "16px Arial";
    ctx.fillStyle = "#0095DD";
    ctx.fillText("Lives: "+ lives, canvas.width-65, 20);
}

function drawBullet(){
    ctx.beginPath();
    ctx.arc(paddleX, canvas.height - paddleHeight, bulletRadius, 0, Math.PI * 2 );
    ctx.fillStyle = "#00DDDD";
    ctx.fill();
    ctx.closePath();
}

function drawShip(){
    ctx.beginPath();
    ctx.fillRect(paddleX, canvas.height - paddleHeight, paddleWidth, paddleHeight);
    ctx.fillStyle = "#0095DD";
    ctx.fill();
    ctx.closePath();
}

function drawBricks() {
    for(var c=0; c<brickColumnCount; c++) {
        for(var r=0; r<brickRowCount; r++) {
        if(bricks[c][r].brickLives > 0){
            var brickX = (c*(brickWidth+brickPadding))+brickOffsetLeft;
            var brickY = (r*(brickHeight+brickPadding))+brickOffsetTop;
            bricks[c][r].x = brickX;
            bricks[c][r].y = brickY;
            ctx.beginPath();
            ctx.rect(brickX, brickY, brickWidth, brickHeight);
            ctx.fillStyle = "#DD9500";
            ctx.fill();
            ctx.closePath();
            }
        }
    }
}

function draw(){
ctx.clearRect(0, 0, canvas.width, canvas.height);
drawBricks();
drawBullet();
drawShip();
collisionDetector();
drawScore();
drawLives();
if(bulletIsFired){
    bulletY += dy;
}

    if(rightPressed && paddleX + paddleWidth < canvas.width){
        paddleX += 7;
    }
    else if(leftPressed && paddleX > 0 ){
        paddleX -= 7;
    }

    if(spacePressed && bulletIsReady){
        bulletIsFired = true;
        bulletIsReady = false;
    }

    if(bulletY < 0){
        bulletIsReady = true;
    }
    
    requestAnimationFrame(draw);
}

draw();