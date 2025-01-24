
//barre de recherche
function searchProduct() {
    // Récupérer la valeur de la recherche
    var searchTerm = document.getElementById('searchInput').value.toLowerCase();
    var rows = document.querySelectorAll('#productTable tbody tr');
    var found = false;

    // Parcourir toutes les lignes du tableau
    rows.forEach(function (row) {
        var productName = row.cells[0].textContent.toLowerCase();
        if (productName.includes(searchTerm)) {
            row.style.display = ''; // Afficher la ligne
            found = true;
        } else {
            row.style.display = 'none'; // Cacher la ligne
        }
    });

    // Si aucun produit n'est trouvé, afficher un message d'erreur
    if (!found && searchTerm.trim() !== '') {
        document.getElementById('productTable').style.display = 'none'; // Cacher le tableau
        document.getElementById('error-message').style.display = 'block'; // Afficher le message d'erreur
    } else {
        document.getElementById('productTable').style.display = ''; // Afficher le tableau
        document.getElementById('error-message').style.display = 'none'; // Cacher le message d'erreur
    }
}

function closeErrorMessage() {
    document.getElementById('error-message').style.display = 'none';
    document.getElementById('productTable').style.display = ''; // Réafficher le tableau complet
    document.getElementById('searchInput').value = ''; // Réinitialiser la barre de recherche
}
