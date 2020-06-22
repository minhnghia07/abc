<?php
    $result = 0;
    $a = $b = $cal = '';
    if(!empty($_GET)){
    	$a = $_GET['a'];
    	$b = $_GET['b'];
    	$cal = $_GET['cal'];

    	switch($cal){
    		case '+':
    		    $result = $a + $b;
    		    break;
    		case '-':
    		    $result = $a - $b;
    		    break;
    		case '*':
    		   $result = $a * $b;
    		   break;
    		case '/':
    		   $result = $a / $b;
    		   break;
    		case '%':
    		   $result = $a % $b;
    		   break;
    	}
    }
?>


<!DOCTYPE html>
<html>
<head>
	<title>Calculator</title>
	<style type="text/css">
		div{
			border:  1px solid black;
			margin: -0px -2.5px -1.5px -2.5px;
		}
		div:hover{
			background: #cccccc;
		}
		div.small {
			width: 48px;
			height: 48px;
			display: inline-block;
			text-align:center;
			cursor: pointer;
		}
		div.small0{
			width: 77px;
			height: 48px;
			display: inline-block;
			padding-left: 20px;

		}
		div.screen{
			height: 75px;
			width: 190px;
			padding-right: 5px;
			overflow :auto;
		}
		div.pheptinh{
			border: none;
			height: 25px;
			width: 100%;
			text-align: right;
		}
		div.result{
			height: 40px;
			width: 100%;
			background: #ccffff;
			border: none;
			text-align: right;
			font-size:xx-large;
			padding-top:10px;
			margin-left: 2.5px;
		}
	</style>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
</head>
<body>
	<form method="get" name="myform">
		<input type="text" name="a" id="a" style="display:none;" value="<?=$result?>" required placeholder="nhap a">
		<input type="text" name="b" id="b" style="display:none;" value="" required placeholder="nhap b">
		<input type="text" name="cal" id="cal" style="display:none;"  required placeholder="nhap phep tinh">
	</form>
	<div class="screen">
		<div class="pheptinh"><?=$a.$cal.$b?></div>
		<div class="result"><?=$result?></div>
	</div></br>

	<div class="small reset" onclick="resetData()">C</div>
	<div class="small">+/-</div>
	<div class="small" onclick="setPhetTinh('%')">%</div>
	<div class="small dau" value="/" onclick="setPhetTinh('/')">/</div></br>
    <div class="small valuable" value="7" onclick="setValue(7)">7</div>
    <div class="small valuable" value="8" onclick="setValue(8)">8</div>
    <div class="small valuable" value="9" onclick="setValue(9)">9</div>
    <div class="small dau" value="*" onclick="setPhetTinh('*')">*</div></br>
    <div class="small valuable" value="4" onclick="setValue(4)">4</div>
    <div class="small valuable" value="5" onclick="setValue(5)">5</div>
    <div class="small valuable" value="6" onclick="setValue(6)">6</div>
    <div class="small dau" value="-" onclick="setPhetTinh('-')">-</div></br>
    <div class="small valuable" value="1" onclick="setValue(1)">1</div>
    <div class="small valuable" value="2" onclick="setValue(2)">2</div>
    <div class="small valuable" value="3" onclick="setValue(3)">3</div>
    <div class="small dau" value="+" onclick="setPhetTinh('+')">+</div></br>
    <div class="small0 valuable" value="0" onclick="setValue(0)">0</div>
    <div class="small valuable" value="." onclick="setValue('.')">.</div>
    <div class="small dau" value="=" onclick="submitForm()">=</div>

    <script type="text/javascript">
        var option = 1;

        function resetData(){
        	option = 1;
        	$("#a").val('')
        	$("#b").val('')
        	$("#cal").val('')
        	buildCal()
        }

    	function setValue(num){
           if(option == 1){
           	   $("#a").val($("#a").val() + num)
           }else{
               $("#b").val($("#b").val() + num)
           }
           buildCal()
    	}
    	function setPhetTinh(pheptinh){
    		if($("#a").val() == ""){
                return;
    		}
    		$('#cal').val(pheptinh)
    		option = 2;
    		buildCal()
    	}
    	function buildCal(){
    		$('.pheptinh').html($("#a").val() + $("#cal").val() + $("#b").val())
    	}
    	function submitForm(){
    		$('[name=myform]').submit()
    	}

    </script>
</body>
</html>