let cart = [];
let total = 0;

function scrollToMenu() {
    document.getElementById('menu').scrollIntoView({ behavior: 'smooth' });
}

function addToCart(itemName, price) {
    const existingItem = cart.find(item => item.name === itemName);
    
    if (existingItem) {
        existingItem.quantity++;
    } else {
        cart.push({
            name: itemName,
            price: price,
            quantity: 1
        });
    }
    
    updateCart();
    showNotification(`${itemName} added to cart!`);
}

function updateCart() {
    const cartItems = document.getElementById('cartItems');
    const cartTotal = document.getElementById('cartTotal');
    const cartCount = document.getElementById('cartCount');
    
    // Update cart items
    cartItems.innerHTML = '';
    total = 0;
    
    cart.forEach(item => {
        const itemTotal = item.price * item.quantity;
        total += itemTotal;
        
        const cartItem = document.createElement('div');
        cartItem.className = 'cart-item';
        cartItem.innerHTML = `
            <div>
                <strong>${item.name}</strong>
                <br>
                <small>R${item.price} x ${item.quantity}</small>
            </div>
            <div>R${itemTotal.toFixed(2)}</div>
        `;
        cartItems.appendChild(cartItem);
    });
    
    // Update totals
    cartTotal.textContent = total.toFixed(2);
    cartCount.textContent = cart.reduce((sum, item) => sum + item.quantity, 0);
}

function toggleCart() {
    document.getElementById('cartSidebar').classList.toggle('active');
}

function closeCart() {
    document.getElementById('cartSidebar').classList.remove('active');
}

function checkout() {
    if (cart.length === 0) {
        alert('Your cart is empty!');
        return;
    }
    
    const orderSummary = cart.map(item => 
        `${item.name} x${item.quantity} - R${(item.price * item.quantity).toFixed(2)}`
    ).join('\n');
    
    alert(`Order Summary:\n\n${orderSummary}\n\nTotal: R${total.toFixed(2)}\n\nThank you for your order! Our staff will prepare it shortly.`);
    
    // Clear cart
    cart = [];
    updateCart();
    closeCart();
}

function showNotification(message) {
    const notification = document.createElement('div');
    notification.style.cssText = `
        position: fixed;
        top: 100px;
        right: 20px;
        background: #d4a574;
        color: #2c1810;
        padding: 1rem 2rem;
        border-radius: 5px;
        z-index: 1002;
        font-weight: bold;
    `;
    notification.textContent = message;
    document.body.appendChild(notification);
    
    setTimeout(() => {
        notification.remove();
    }, 3000);
}

// Close cart when clicking outside
document.addEventListener('click', (e) => {
    const cartSidebar = document.getElementById('cartSidebar');
    const cartIcon = document.querySelector('.cart-icon');
    
    if (!cartSidebar.contains(e.target) && !cartIcon.contains(e.target)) {
        closeCart();
    }
});