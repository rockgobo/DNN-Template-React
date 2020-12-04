function Welcome(props) {
    return /*#__PURE__*/React.createElement("h1", null, "Hello, ", props.name);
}

function App() {
    return /*#__PURE__*/React.createElement("div", null, /*#__PURE__*/React.createElement(Welcome, {
        name: "Sara"
    }), /*#__PURE__*/React.createElement(Welcome, {
        name: "Cahal"
    }), /*#__PURE__*/React.createElement(Welcome, {
        name: "Edite"
    }));
}


$(window).load(function () {
    ReactDOM.render( /*#__PURE__*/React.createElement(App, null), document.getElementById('root'));
})