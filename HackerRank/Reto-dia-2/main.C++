#include <iostream>
#include <cmath>
using namespace std;

void solve(double meal_cost, int tip_percent, int tax_percent) {
    double tip = meal_cost * tip_percent / 100.0;
    double tax = meal_cost * tax_percent / 100.0;
    int total_cost = round(meal_cost + tip + tax);
    
    cout << total_cost << endl;
}

int main() {
    double meal_cost;
    int tip_percent, tax_percent;
    
    cin >> meal_cost >> tip_percent >> tax_percent;
    solve(meal_cost, tip_percent, tax_percent);
    
    return 0;
}