import React, { useState, useEffect } from 'react';
import DrinkOption from './DrinkOption'

export function Home() {
    const [drinks, setDrinks] = useState([]);

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
        drinks.map((drink) => (<DrinkOption drink={drink} />))
    );
}
