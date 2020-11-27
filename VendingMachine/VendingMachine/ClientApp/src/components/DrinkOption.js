import React from 'react'

export default function DrinkOption(props) {
    return(
        <div className='drink-option'>
            <div>{props.drink.name}</div>
        </div>
    )
}