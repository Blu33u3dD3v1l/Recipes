//const toggleButtons = document.querySelectorAll('.toggle-description-btn');
//const descriptionElements = document.querySelectorAll('.recipe-description');

//// Function to toggle description visibility
//function toggleDescription(event) {
//    const cardBody = event.target.closest('.card-body');
//    const descriptionElement = cardBody.querySelector('.recipe-description');
//    descriptionElement.classList.toggle('d-none');
//}

//// Add click event listener to each toggle button
//toggleButtons.forEach(button => {
//    button.addEventListener('click', toggleDescription);
//});
// Get all toggle buttons and description elements
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