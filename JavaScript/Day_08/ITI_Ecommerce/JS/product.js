// --------------------Product----------------------
// 1.Fetch 
const API = 'https://fakestoreapi.com/products';

const productsRow = document.getElementById('products_list')

let productData = []

async function fetchProducts() {
    try {
        const result = await fetch(API)
        productData = await result.json();
        displayProducts(productData)
    }
    catch (error) {
        console.log(error)
        productsRow.innerHTML = `'<p class="text-danger">ERROR!</p>';`
    }
}

fetchProducts()

// 2. Display Products
function displayProducts(products) {
    productsRow.innerHTML = ''; 
    products.forEach(product => {
        const col = document.createElement('div'); 
        col.className = 'col-12 col-sm-6 col-md-4 col-lg-3 mb-4';


        // Card template
        col.innerHTML = `
            <div class="card ">
                <img src="${product.image}" class="card-img-top" alt="${product.title}">
                <div class="card-body text-center">
                    <h5 class="card-title">${product.title}</h5>
                    <p class="card-text">$${product.price}</p>
                    <button class="btn btn-success" onclick="addToCart(${product.id})">Add to Cart</button>
                </div>
            </div>
        `;
        productsRow.appendChild(col);
    });
}

// 3.Add to cart
function addToCart(id)
{
    let cart=JSON.parse(localStorage.getItem("cart")) ||[]

    let product =productData.find(p=>p.id==id)

    let existingProduct =cart.find(p=>p.id==id)

    if (existingProduct)
    {
        existingProduct.quantity+=1;
    }
    else 
    {
        cart.push({...product,quantity:1})
    }

    localStorage.setItem("cart",JSON.stringify(cart));

    window.location.href="../Cart.html"
}


