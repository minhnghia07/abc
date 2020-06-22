<?php
    require_once('config.php');

    function execute($sql){
    	$conn = mysqli_connect(HOST,USERNAME, PASSWORD, DATABASE);
    	//QUERY

    	mysqli_query($conn, $sql);

    	mysqli_close($conn);
    }

    function executeResult($sql){
    	//create connection toi database
    	$conn = mysqli_connect(HOST, USERNAME,PASSWORD,DATABASE);

    	$resultSet = mysqli_query($conn, $sql);
    	$list = [];
    	while($row = mysqli_fetch_array($resultSet, 1)){
    		$list[] = $row;
    	}

    	mysqli_close($conn);
    	return $list ;
    }
?>