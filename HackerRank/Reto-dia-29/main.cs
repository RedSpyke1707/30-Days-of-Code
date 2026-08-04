'use strict';

function bitwiseAnd(N, K) {
    if (((K - 1) | K) <= N) {
        return K - 1;
    } else {
        return K - 2;
    }
}

function main() {
    const fs = require('fs');
    const input = fs.readFileSync(0, 'utf-8').trim().split(/\s+/);
    
    if (input.length === 0 || input[0] === "") return;
    
    const t = parseInt(input[0], 10);
    let idx = 1;
    
    for (let i = 0; i < t; i++) {
        const n = parseInt(input[idx], 10);
        const k = parseInt(input[idx + 1], 10);
        idx += 2;
        
        console.log(bitwiseAnd(n, k));
    }
}

main();