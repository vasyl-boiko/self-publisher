import React from 'react';
import ReactDOM from 'react-dom';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { getAutors } from './autorActions.jsx'

class Autor extends React.Component {

    componentDidMount() {
        this.props.getAutors(0);
    }

    render() {
        let autors = this.props.autors.records.map(item => {
            return (
                <div key={item.id} className="autor">
                    <div className="header">{item.firstName}</div>
                    <div className="content">{item.lastName}</div>
                    <hr />
                </div>
            );
        });

        return (
            <div id="autor">
                {autors}
            </div>
        );
    }
};

let mapProps = (state) => {
    return {
        autors: state.autor.data,
        error: state.autor.error
    }
}

let mapDispatch = (dispatch) => {
    return {
        getAutors: bindActionCreators(getAutors, dispatch)
    }
}

export default connect(mapProps, mapDispatch)(Autor) 