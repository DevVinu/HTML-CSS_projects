const btn = document.querySelector('.btn');

// Function to update glow
function updateGlow(e, scale = 1) {
    const rect = btn.getBoundingClientRect();
    const centerX = rect.left + rect.width / 2;
    const centerY = rect.top + rect.height / 2;

    const x = e.clientX - centerX;
    const y = e.clientY - centerY;

    const offsetX = (x / 15) * scale;
    const offsetY = (y / 15) * scale;

    // Directional neon glow
    btn.style.boxShadow = `
        ${offsetX}px ${offsetY}px 4px rgba(191, 109, 191, 0.9),
        ${offsetX}px ${offsetY}px 8px rgba(0, 0, 0, 0.5),
        ${offsetX}px ${offsetY}px 12px rgba(0, 0, 0, 0.2)
    `;
}

// Detect mouse near button
document.addEventListener('mousemove', (e) => {
    const rect = btn.getBoundingClientRect();
    const padding = 20; // area outside button to trigger glow

    if (
        e.clientX > rect.left - padding && e.clientX < rect.right + padding &&
        e.clientY > rect.top - padding && e.clientY < rect.bottom + padding
    ) {
        updateGlow(e); // glow active
    } else {
        btn.style.boxShadow = 'none'; // CSS transition fades it out
    }
});

// Hover out fade
btn.addEventListener('mouseleave', () => {
    btn.style.boxShadow = 'none'; // transition handles smooth fading
});