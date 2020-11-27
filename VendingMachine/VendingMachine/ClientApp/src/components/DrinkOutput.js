import React from 'react'

export default function DrinkOutput(props) {
    if (props.drink !== null) {
        return (
            <div>
                <p>You ordered {props.drink.name}</p>
                <ul>
                    {props.drink.steps.map(step => <li>{step}</li>)}
                </ul>
            </div>
        )
    } else {
        return (
            <div>
                You have not ordered a drink!
            </div>
        )
    }
}

DrinkOutput.defaultProps = {
    drink: null
}