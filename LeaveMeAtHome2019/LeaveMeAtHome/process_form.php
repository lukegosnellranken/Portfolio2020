<?php
	print_r($_POST);
/*	die;	*/
	
	//	Define variables and set to empty values
	$fname_error = $lname_error = $email_error = $phone_error = "";
	$fname       = $lname       = $email       = $phone  =  $questions = $upload = $success = "";
	$message_body = "";
	
	//	Form submitted with POST method
	if ($_SERVER["REQUEST_METHOD"] == "POST") {
		//	Validate first name field.
		//	Can be letters or whitespace only
		if (empty($_POST["fname"])) {
			$fname_error = "Required!";
		}	//	End if (empty($_POST["fname"]))
		else {
			//	Some input provided
			$fname = test_input($_POST["fname"]);

			//	Check that name only contains letters & whitespace
			if (!preg_match("/^[a-zA-Z]+$/", $fname)) {
				$fname_error = "Letters only";
			}	//	End if (!pref_match("/^[a-zA-Z *$/", $fname))
			else {
				$fname_error = "";
			}
		}	//	End else on if (empty($_POST["fname"]))
		
		//	Validate last name field.
		//	Like first, can be letters or whitespace only
		if (empty($_POST["lname"])) {
			$lname_error = "Required!";
		}	//	End if (empty($_POST["lname"]))
		else {
			//	Some input provided
			$lname = test_input($_POST["lname"]);

			//	Check that name only contains letters & whitespace
			if (!preg_match("/^[a-zA-Z]+$/", $lname)) {
				$lname_error = "Letters only";
			}	//	End if (!pref_match("/^[a-zA-Z *$/", $lname))
			else {
				$lname_error = "";
			}
		}	//	End else on if (empty($_POST["lname"]))
		
		//	Validate email field.
		//	Must be valid email address
		if (empty($_POST["email"])) {
			$email_error = "Required!";
		}	//	End if (empty($_POST["email"]))
		else {
			//	Some input provided
			$email = test_input($_POST["email"]);
			
			//	Check if email address well formed
			if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
				$email_error = "Invalid email format";
			}	//	End if (!filter_var($email, FILTER_VALIDATE_EMAIL))
			else {
				$email_error = "";
			}
		}	//	End else on if (empty($_POST["email"]))
		
		//	Validate phone number field.
		//	Must be in nnn-nnn-nnnn format
		if (empty($_POST["phone"])) {
			$phone_error = "Required!";
		}	//	End if (empty($_POST["phone"]))
		else {
			$phone = test_input($_POST["phone"]);
			
			//	Check if phone number valid
			//	i.e. numeric and in nnn-nnn-nnnn pattern
			if (!preg_match("/^(\d[\s-]?)?[\([\s-]{0,2}?\d{3}[\)\]\s-]{0,2}?\d{3}[\s-]?\d{4}$/i", $phone)) {
				$phone_error = "Invalid phone number format";
			}	//	End if (!preg_match...)
			else {
				$phone_error = "";
			}
		}	//	End else on if (empty($_POST["phone"]))
	
		//	Check for no form field errors
		if (($fname_error == "") and ($lname_error == "") and
			($email_error == "") and ($phone_error == "")) {
			unset($_POST['submit']);
			
			//	Add the fields to the mail message body
			foreach ($_POST as $key => $value) {
				$message_body .= "$key: $value<br>";
			}	//	End foreach
			
			$success = $message_body;
			
			$to 	 = 'tomparham718@gmail.com ';
			$subject = 'Leave Me At Home Contact Form Submit';
			
			if (mail($to, $subject, $message)) {
				$fname = $lname = $email = $phone = $questions = $upload = "";
			}
		}	//	End if no form field errors
		
		if (isset($message_body)) {
			$success = $message_body . "  Message sent.  Thanks.  We'll get back to you shortly";;
		}
		else {
			$success = "Problem with input.  Please try again later.";			
		}
	}	//	End if ($_SERVER["REQUEST_METHOD"] == "POST")
		
	function test_input($data) {
		$data = trim($data);
		$data = stripslashes($data);
		$data = htmlspecialchars($data);
		
		return $data;
	}
?>	