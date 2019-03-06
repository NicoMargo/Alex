function Alogin(){
	location.href='login.html'
}
function Acarrito(){
	location.href='Carrito.html'
}

const express = require('express');
const morgan = require('morgan');
const app = express();

app.set('port', process.env.PORT || 4000 );
app.use(morgan('dev'));



//Routes
app.use(require('../Routes/Index'));
// Public

// Starting the server
app.listen(app.get('port'),() => {
	console.log('server on port', app.get('port'));
});