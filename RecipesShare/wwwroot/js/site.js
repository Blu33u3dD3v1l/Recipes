const toggleButtons = document.querySelectorAll('.toggle-description-btn');

// Function to toggle description visibility
function toggleDescription(event) {
    const cardBody = event.target.closest('.card-body');
    const descriptionElement = cardBody.querySelector('.recipe-description');
    descriptionElement.classList.toggle('d-none');
}

// Add click event listener to each toggle button
toggleButtons.forEach(button => {
    button.addEventListener('click', toggleDescription);
});

function addIngredient() {
    var ingredientInputs = document.getElementById('ingredientInputs');
    var newInput = document.createElement('div');
    newInput.className = 'form-group';
    newInput.innerHTML = '<label for="ingredientInput">Add Ingredient:</label>' +
        '<input type="text" class="form-control" name="ingredient" placeholder="Enter ingredient">';
    ingredientInputs.appendChild(newInput);
}

function saveIngredients() {
    var ingredientInputs = document.getElementsByName('ingredient');
    var ingredientList = document.getElementById('ingredientList');
    ingredientList.innerHTML = ''; // Clear previous list
    for (var i = 0; i < ingredientInputs.length; i++) {
        var ingredient = ingredientInputs[i].value.trim();
        if (ingredient !== '') {
            var listItem = document.createElement('li');
            listItem.className = 'list-group-item';
            listItem.textContent = ingredient;
            ingredientList.appendChild(listItem);
        }
    }
}