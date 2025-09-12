// 1.Get items from local storage 
let cart =JSON.parse(localStorage.getItem("cart"))||[]

// 2.Get html element for cart list 
const cartTable= document.getElementById("cart_list")


// 3.Display items
function displayCart() {
    cartTable.innerHTML = ""; 
    let total = 0;

    cart.forEach((item, index) => {
        const row = document.createElement("tr");

        row.innerHTML = `
            <td><img src="${item.image}" alt="${item.title}" style="height: 50px;"></td>
            <td>${item.title}</td>
            <td>$${item.price}</td>
            <td>
                <button class="btn btn-sm btn-outline-secondary" onclick="changeQuantity(${item.id}, -1)">-</button>
                <span class="mx-2">${item.quantity}</span>
                <button class="btn btn-sm btn-outline-secondary" onclick="changeQuantity(${item.id}, 1)">+</button>
            </td>
            <td>$${(item.price * item.quantity).toFixed(2)}</td>
            <td>
                <button class="btn btn-danger btn-sm" onclick="removeFromCart(${item.id})">Remove</button>
            </td>
        `;

        cartTable.appendChild(row);
        total += item.price * item.quantity;
    });
    document.getElementById("cart_total").textContent = total.toFixed(2);
}

// 4.Change Quantity 
function changeQuantity(id, change) {
    let product = cart.find(p => p.id === id);
    if (product) {
        product.quantity += change;

        
        if (product.quantity <= 0) {
            cart = cart.filter(p => p.id !== id);
        }

        localStorage.setItem("cart", JSON.stringify(cart));
        displayCart(); 
    }
}

// 5.remove item
function removeFromCart(id) {
    cart = cart.filter(p => p.id !== id);
    localStorage.setItem("cart", JSON.stringify(cart));
    displayCart();
}

// 6.Success
function purchaseCart() {
    if (cart.length === 0) {
        alert("Your cart is empty!");
        return;
    }

    alert("Cart purchased successfully!");
    cart = [];
    localStorage.setItem("cart", JSON.stringify(cart));
    displayCart(); 
}

// Call 
displayCart();