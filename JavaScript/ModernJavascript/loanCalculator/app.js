//Listen for submit
document.getElementById('loan-form').addEventListener('submit', function(e){
    // Hide results
    document.getElementById('results').style.display='none';

    // Show loader
    document.getElementById('loading').style.display='block';

    setTimeout(calculateResults, 2000);

    e.preventDefault();
});

//Calculate Results
function calculateResults(){
    console.log('Calculating...');
    
    //UI vars
    const UIamount = document.getElementById('amount');
    const UIinterest = document.getElementById('interest');
    const UIyears = document.getElementById('years');
    const UImonthlyPay = document.getElementById('monthly-payment')
    const UItotalPay = document.getElementById('total-payment');
    const UItotalInterest = document.getElementById('total-interest');

    const principal = parseFloat(amount.value);
    const calculatedInterest = parseFloat(interest.value) / 100 / 12;
    const calculatedPayments = parseFloat(years.value) * 12;

    //Compute monthly payment
    const x = Math.pow(1 + calculatedInterest, calculatedPayments);
    const monthly = (principal * x * calculatedInterest)/(x-1);

    if(isFinite(monthly)){
        UImonthlyPay.value = monthly.toFixed(2);
        UItotalPay.value = (monthly * calculatedPayments).toFixed(2);
        UItotalInterest.value = ((monthly * calculatedPayments)-principal).toFixed(2);

        // Display results
        document.getElementById('results').style.display='block';

        //Hide loader
        document.getElementById('loading').style.display='none';

    } else {
        showError('Please check your numbers');

        //Hide loader
        document.getElementById('loading').style.display='none';
    }
}

// Show error
function showError(error){
    // Create div
    const errorDiv = document.createElement('div');

    // Get elements
    const card = document.querySelector('.card');
    const heading = document.querySelector('.heading');

    // Add classes
    errorDiv.className = "alert alert-danger";

    // Create text node and append to div
    errorDiv.appendChild(document.createTextNode(error));

    // Insert error above heading
    card.insertBefore(errorDiv, heading);

    // Clear error after 3 seconds
    setTimeout(clearError, 3000);
}

// CLear error
function clearError(){
    document.querySelector('.alert').remove();
}