﻿function Welcome(props) {
    return <h1>Hello, {props.name}</h1>;
}

function App() {
    return (
        <div>
            <Welcome name="Sara" />
            <Welcome name="Cahal" />
            <Welcome name="Edite" />
            <Welcome name="Bob" />
        </div>
    );
}

$(window).load(function () {
    ReactDOM.render(
        <App />,
        document.getElementById('root')
    );
});
