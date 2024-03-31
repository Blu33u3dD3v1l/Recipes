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
    var container = document.getElementById('ingredientsContainer');
    var index = container.children.length; // Next index for new ingredient

    var newIngredientHtml = `
            <div>
                <input type="text" name="Ingredients[${index}].Name" />
                <button type="button" onclick="removeIngredient(${index})">Remove</button>
            </div>
        `;
    container.insertAdjacentHTML('beforeend', newIngredientHtml);
}

function removeIngredient(index) {
    var container = document.getElementById('ingredientsContainer');
    container.removeChild(container.children[index]);
}