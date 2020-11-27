import React from 'react'
import { Button } from 'reactstrap';

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
        <Button className='drink-option' onClick={orderDrink}>
            <div className='summary'>{props.drink.name}</div>
            <div className='image-container'>
                <img src='/icons/drinkIcon.png' />
            </div>
        </Button>
    )
}