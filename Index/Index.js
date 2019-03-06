function CosasGastiXD(){
	console.log(e.edad)

	$(document).ready(function(){
		$('.texto').css('color', 'Green')
		const test = 2
		const test2 = 3
		console.log(test + test2)
	})
	
	const a = 1
	const b = 'asd'
	const c = true
	const d = [1, 2, 3, 'asd', [0, 2]]
	const e = {
		edad: 21,
		altura: '1.10m',
		decirHola: function(){
			console.log(e.edad)
		}
	}	
	e.decirHola()
}
function CambioColor()	{
$(document).ready(function(){
	$('.texto').css('color', 'Green')
})
}
function Alogin(){
	location.href='login.html'
}
function Acarrito(){
	location.href='Carrito.html'
}