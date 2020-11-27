import React from 'react'

export default function DrinkOption(props) {
    const orderDrink = () => {
        const fetchData = async () => {
            let response = null;
            response = await fetch(`api/drink/${props.drink.id}`);
            const drink = await response.json();
            props.setOrderedDrink(drink);
        };
        fetchData();
    }

    return(
        <div className='drink-option' onClick={orderDrink}>
            <div>{props.drink.name}</div>
        </div>
    )
}