let canvas = document.getElementById("snake"); // Suca elemento da html che sarà il serpentone grafico
let context = canvas.getContext("2d"); //....
let box = 32; // campo
let snake = []; // serpente lato codice come listone di robba

// inizializzo posizione iniziale serpentello
snake[0] = {
  x: 8 * box,
  y: 8 * box,
};
let direction = "right"; // direzione iniziale che seguirà il serpentone

// inizializzo posizione manciare
let food = {
  x: Math.floor(Math.random() * 15 + 1) * box,
  y: Math.floor(Math.random() * 15 + 1) * box,
};

//riempie er campo pazzo sgravato
function drawBG() {
  context.fillStyle = "lightgreen";
  context.fillRect(0, 0, 16 * box, 16 * box);
}

//riempie e quadratini dello snake pazzo sgravato
function drawSnake() {
  for (i = 0; i < snake.length; i++) {
    context.fillStyle = "darkgreen";
    context.fillRect(snake[i].x, snake[i].y, box, box);
  }
}

//riempie e quadratini der cibbo pazzo sgravato
function dropFood() {
  context.fillStyle = "orange";
  context.fillRect(food.x, food.y, box, box);
}

//vede se succede un evento e lo chiama: mbare veni cca!
document.addEventListener("keydown", update);

// rileva la pressione delle freccie e cambia la direzione del serpentello
function update(event) {
  if (event.keyCode == 37 && direction != "right") direction = "left";
  if (event.keyCode == 38 && direction != "down") direction = "up";
  if (event.keyCode == 39 && direction != "left") direction = "right";
  if (event.keyCode == 40 && direction != "up") direction = "down";
}

//praticamente a main funzione
function initTuttuCosi() {
  if (snake[0].x > 15 * box && direction == "right") snake[0].x = 0;
  if (snake[0].x < 0 && direction == "left") snake[0].x = 16 * box;
  if (snake[0].y > 15 * box && direction == "down") snake[0].y = 0;
  if (snake[0].y < 0 && direction == "up") snake[0].y = 16 * box;

  for (i = 1; i < snake.length; i++) {
    if (snake[0].x == snake[i].x && snake[0].y == snake[i].y) {
      clearInterval(game);
      alert("Si cunzumatu!");
    }
  }

  drawBG();
  drawSnake();
  dropFood();

  let snakeX = snake[0].x;
  let snakeY = snake[0].y;

  if (direction == "right") snakeX += box;
  if (direction == "left") snakeX -= box;
  if (direction == "up") snakeY -= box;
  if (direction == "down") snakeY += box;

  //rimuove l'ultimo elemento di snake(culo serpente) se non mangia se no procederà a ridroppare er food
  if (snakeX != food.x || snakeY != food.y) {
    snake.pop();
  } else {
    food.x = Math.floor(Math.random() * 15 + 1) * box;
    food.y = Math.floor(Math.random() * 15 + 1) * box;
  }

  let newHead = {
    x: snakeX,
    y: snakeY,
  };

  snake.unshift(newHead);
}

let game = setInterval(initTuttuCosi, 100);
