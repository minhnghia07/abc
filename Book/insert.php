 <?php
    require_once('dbhelper.php');

    $account = $email = $username =  $phone = $password = '';
    
    if(!empty($_POST)){
    	if(isset($_POST['account'])){
    		$account = $_POST['account'];
    	}if(isset($_POST['email'])){
    		$email = $_POST['email'];
    	}
    	if(isset($_POST['username'])){
    		$username = $_POST['username'];
    	}
    	if(isset($_POST['phone'])){
    		$phone = $_POST['phone'];
    	}
    	if(isset($_POST['password'])){
    		$password = $_POST['password'];
    	}
    	// setcookie('account', $account, time() + 3600, '/');
    	// setcookie('email', $email, time() + 3600, '/');
    	// setcookie('username', $username, time() + 3600, '/');
    	// setcookie('phone', $phone, time() + 3600, '/');
    	// setcookie('password', $password, time() + 3600, '/');
         

        // $account = str_replace('\'', '\\\'', $account);
        // $email = str_replace('\'', '\\\'', $email);
        // $username = str_replace('\'', '\\\'', $username);
        // $phone = str_replace('\'', '\\\'', $phone);
        // $password = str_replace('\'', '\\\'', $password);
        if ($email == '' && $password == '') {
            echo 'cut';
        }else{
    	$sql = "insert into userr(name_account, email,fullname ,phone, password) value ('$account', '$email', '$username', '$phone', '$password')";
        execute($sql);
        header('Location :login.php');
        die();
    }
    }
   
?> 