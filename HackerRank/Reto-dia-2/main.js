'use strict';

const readline = require('readline');

// Creamos la interfaz de lectura para la terminal
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function solve(meal_cost, tip_percent, tax_percent) {
    const tip = meal_cost * (tip_percent / 100);
    const tax = meal_cost * (tax_percent / 100);
    const totalCost = meal_cost + tip + tax;
    
    // Corregido: totalCost en lugar de totalCostC
    console.log(`\nEl costo total es: ${Math.round(totalCost)}`);
}

// Preguntas secuenciales en la terminal
rl.question('Entre el costo de la comida: ', (mealInput) => {
    rl.question('Entre el porcentaje de propina: ', (tipInput) => {
        rl.question('Entre el porcentaje de impuesto: ', (taxInput) => {
            
            const meal_cost = parseFloat(mealInput.trim());
            const tip_percent = parseInt(tipInput.trim(), 10);
            const tax_percent = parseInt(taxInput.trim(), 10);

            solve(meal_cost, tip_percent, tax_percent);

            rl.close(); // Cerramos la terminal
        });
    });
});