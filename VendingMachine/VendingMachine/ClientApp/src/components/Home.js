import React, { useState, useEffect } from 'react';
import DrinkOption from './DrinkOption'
import DrinkOutput from './DrinkOutput'

export function Home() {
    const [drinks, setDrinks] = useState([]);
    const [orderedDrink, setOrderedDrink] = useState();

    useEffect(() => {
        const fetchData = async () => {
            let response = null;
            response = await fetch("api/drink");
            const drinks = await response.json();
            setDrinks(drinks);
        };
        fetchData();
    }, [])

    return (
        <div>
            {drinks.map((drink) => (<DrinkOption drink={drink} setOrderedDrink={setOrderedDrink} />))}
            <div>
                <DrinkOutput drink={orderedDrink}/>
            </div>
        </div>
    );
}
